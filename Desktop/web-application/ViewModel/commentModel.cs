using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace web_project.ViewModel
{
    public class commentModel
    {
        public int commentId { get; set; }

        [Required(ErrorMessage = "Adınızı ve Soyadınızı Giriniz!")]
        [Display(Name = "Ad Soyad")]
        [StringLength(50, ErrorMessage = "Adı Soyadı En Fazla 50 Karakter" +
           "Olmalı!")]
        public string commentorName { get; set; }

        [Required(ErrorMessage = "E-mail Adresinizi Giriniz!")]
        [Display(Name = "E-mail")]
        [StringLength(20, ErrorMessage = "E-mail adresi En Fazla 20 Karakter" +
           "Olmalı!")]
        public string commentorMail { get; set; }

        public Nullable<bool> commentApprove { get; set; }

        /*[Required(ErrorMessage = "Bugünün Tarihini Giriniz!")]
        [Display(Name = "Adres")]
        [StringLength(200, ErrorMessage = "Adı Soyadı En Fazla 200 Karakter" +
           "Olmalı!")]*/
        public Nullable<System.DateTime> commentDate { get; set; }

        [Required(ErrorMessage = "Yorumunuzu Giriniz!")]
        [Display(Name = "Yorum")]
        [StringLength(200, ErrorMessage = "Yorum Alanı En Fazla 200 Karakter" +
           "Olmalı!")]
        public string commentContent { get; set; }
    }
}