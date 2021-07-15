using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfStiDal : EfEntityRepositoryBase<Sti, TestContext>, IStiDal
    {
        public List<StiJoinStk> GetStiJoinStks(Expression<Func<StiJoinStk, bool>> filter = null)
        {
            using (TestContext context = new TestContext())
            {
                stok = 0;
                var result = from sti in context.Stis
                             join stk in context.Stks
                             on sti.MalKodu equals stk.MalKodu
                             orderby sti.Tarih ascending
                             select new StiJoinStk
                             {
                                 SiraNo = sti.Id,
                                 IslemTur = sti.IslemTur == 0 ? "Giriş" : "Çıkış",
                                 EvrakNo = sti.EvrakNo,
                                 GirisMiktar = sti.IslemTur == 0 ? sti.Miktar : 0,
                                 CikisMiktar = sti.IslemTur == 1 ? sti.Miktar : 0,
                                 StokMiktar = sti.IslemTur == 0 ? Hesapla(true, sti.Miktar) : Hesapla(false, sti.Miktar),
                                 Tarih = GunDonusturme.Donusturme(sti.Tarih)
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
        }
        

        static decimal stok = 0;
        private static decimal Hesapla(bool deger, decimal miktar)
        {
            return deger == true ? stok += miktar : stok -= miktar;
        }
    }
    public static class GunDonusturme
    {
        public static int Donusturme(int deger)
        {
            int sabit = 1900, yil, ay, gun;
            yil = deger / 365;
            gun = deger - yil * 365;
            ay = gun / 30;
            gun %= 30;
            yil += sabit;
            string birlestir = yil.ToString() + ay.ToString() + gun.ToString();
            return Convert.ToInt32(birlestir);
        }
    }
}
