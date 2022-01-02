using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_project.ViewModel
{
    public class userModel
    {
        public int id { get; set; }

        [Required(ErrorMessage ="Adı Soyadı Giriniz!")]
        [Display(Name="Adı Soyadı")]
        [StringLength(50,ErrorMessage ="Adı Soyadı En Fazla 50 Karakter" +
            "Olmalı!")]        
        public string usernameSurname { get; set; }

        [Required(ErrorMessage = "E-mailinizi Giriniz!")]
        [Display(Name = "E-mail")]
        [StringLength(20, ErrorMessage = "E-mail Adresi En Fazla 20 Karakter" +
            "Olmalı!")]
        public string email { get; set; }

        [Required(ErrorMessage = "Parolanızı Giriniz!")]
        [Display(Name = "Parola")]
        [StringLength(8, ErrorMessage = "Parola En Fazla 8 Karakter" +
            "Olmalı!")]
        public string passwd { get; set; }

        [Required(ErrorMessage = "Kilonuzu Giriniz!")]
        [Display(Name = "Kilo")]
        [StringLength(5, ErrorMessage = "Ağırlık Değeri En Fazla 5 Karakter" +
            "Olmalı!")]
        public Nullable<decimal> kg { get; set; }

        [Required(ErrorMessage = "Boyunuzu Giriniz!")]
        [Display(Name = "Boy")]
        [StringLength(3, ErrorMessage = "Uzunluk Değeri En Fazla 3 Karakter" +
            "Olmalı!")]
        public Nullable<decimal> boy { get; set; }

        [Required(ErrorMessage = "Günlük Tükettiğiniz Su Miktarını Giriniz!")]
        [Display(Name = "Su Miktarı")]
        [StringLength(5, ErrorMessage = "Günlük Tüketilen Su Miktarı En Fazla 5 Karakter" +
            "Olmalı!")]
        public Nullable<decimal> water { get; set; }

        [Required(ErrorMessage = "Çalışmak İstediğiniz Bölgeyi Seçiniz!")]
        [Display(Name = "Bilge")]
        public string area { get; set; }

        [Required(ErrorMessage = "Telefon Numaranızı Boşluk Bırakmadan 11 Haneli Giriniz!")]
        [Display(Name = "Telefon Numarası")]
        [StringLength(11, ErrorMessage = "Telefon Numarası En Fazla 11 Karakter" +
            "Olmalı!")]
        public string tel { get; set; }

        [Required(ErrorMessage = "Doğum Tarihinizi Giriniz!")]
        [Display(Name = "Doğum Tarihi")]
        [StringLength(10, ErrorMessage = "Doğum Tarihi En Fazla 10 Karakter" +
            "Olmalı!")]
        public Nullable<System.DateTime> birth { get; set; }

        [Required(ErrorMessage = "Adresinizi Giriniz!")]
        [Display(Name = "Adres")]
        [StringLength(200, ErrorMessage = "Adı Soyadı En Fazla 200 Karakter" +
            "Olmalı!")]
        public string address { get; set; }
    }
}