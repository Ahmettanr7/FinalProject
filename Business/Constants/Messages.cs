using Core.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Business.Constants
{
    public static class Messages
    {
        public static string ProductAdded = "Ürün eklendi";
        public static string ProductNameInvalid = "Ürün ismi geçersiz";
        public static string MaintenanceTime = "Sistem bakım zamanı daha sonra tekrar deneyiniz.";
        public static string ProductListed = "Ürünler listelendi";
        public static string UnitPriceInvalid = "Tutar hatalı";
        public static string ProductCountOfCategoryError = "Bu kategoride en fazla 10 ürün sergilenebilir.";
        public static string ProductUpdated = "Ürün güncellendi";
        public static string SameNameCanNotBeAdded = "Bu kategoride zaten bu isimde ürün var";
        public static string CategoryLimitExists = "Yeni ürün eklenemiyor. Kategori limiti aşıldı.";
        public static string AuthorizationDenied = "yetkiniz yok";
        public static string UserRegistered = "Kayıt olundu";
        public static string UserNotFound = "Kullanıcı bulunamadı";
        public static string PasswordError = "Şifre hatalı";
        public static string SuccessfulLogin = "Giriş başarılı";
        public static string UserAlreadyExists = "Kullanıcı zaten var";
        public static string AccessTokenCreated = "Erişim jetonu oluşturuldu";
    }
}
