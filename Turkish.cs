﻿using System.Collections.Generic;
using static Bot.Translations._Trans;

namespace Bot.Translations
{
    public class Turkish
    {
        public static _Trans Language = new _Trans
        {
            Error = new TError
            {
                NoEmbedPerms = "Botun yetkisi yok \" Embed Linki \"",
                AdminOnly = "sen server admini değilsin",
                PlayerNotFound = "Oyuncu {0} Bulunamadi",
                ApiError = "API hatasi",
                EnterIP = "sunucu ipsini gir",
                InvalidIP = "boyle bir ip yok",
                Cooldown = "komutlari tekrar kullanmak için 1 dakka bekle",
                EnableQuery = "Minecraft sunucusu, sunucu.propertiesinde etkinleştirme sorgusu ayarlamadı",
                ListNoServers = "Bu topluluk listede bulunmuyor",
                UnknownArg = "Unknown argument do",
                TextLimit = "yazı limiti 22 olarak ayarlandı",
                RequireAttachFiles = "botun bir resim atmak için yetkisi yok",
                UnknownWiki = "wiki eşyasi bulunamadi"
            },

            Main = new TMain
            {
                Commands = new List<string>
                {
                    "[ mc/bot ]( Bot Davet/Bilgi/istatistik/Linkler )",
                    "[ mc/quiz ]( Minecraft testleri :D )",
                    "[ mc/skin {p} ]( Oyuncu cildi )",
                    "[ mc/colors ]( MC renk kodlari )",
                    "[ mc/hypixel {p} ]( Hypixel oyuncu istatistigi )",
                    "[ mc/hive {p} ]( HiveMC player stats )",
                    "[ mc/wynncraft (Oyuncu) ]( Wynncraft player stats )",
                    "[ mc/ping (IP) ]( serverin pingini gosterir )",
                    "[ mc/list ]( topluluk serverlerini listeler )",
                    "[ mc/wiki ]( Wiki de Itemler/Yaratiklar/Buyuler/iksirler )",
                    "[ mc/version ]( Minecraft version bilgisi )",
                    "[ mc/names {p} ]( MC hesabi isim geçmisi )",
                    "[ mc/status ]( Mojang istatistikleri )",
                    "[ mc/get {p} ]( Başarim olarak gosterir )",
                    "[ mc/playing ]( bu kişi minecraft oynuyormu )",
                    "[ mc/user ]( Senin minecraft hesabin, cildin ve istatistikler )",
                    "[ mc/rcon ]( Remote console for your Minecraft server )",
                    "[ mc/admin ]( topluluk admini komutlari )",
                    "[ mc/uuid (oyuncu) ]( oyuncu UUID )",
                    "[ mc/invite ]( botu davet etmek için kullan )"
                },
                HelpFooter = "bazı gizli komutlarda var evlat ;)",
                MultiMC = "MultiMC birden fazla modu ve cild kurulumunu kolaylaştirmanizi sağlar",
                PleaseWait = "Lutfen bekle ben pingliyim",
                ServerAdminUse = "Sadece server admini kullana bilir",
                StoleSkin = "çaldi cilt",
                NameOnlyOne = "Oyuncu {0} sadece 1 isim ile kayitli",
                PlayingMinecraft = "kullanici minecraft oynuyor",
                Hi = "Merhaba",
                BotDesc = "Herhangi bir sorun, öneri veya dil çevirileriniz varsa lütfen bana ulaşın.",
                First = "İlk"
            },

            Hidden = new THidden
            {
                FoundHiddenCommand = "Hey, sen gizli komutlari buldun :D",
                Herobrine = "Herzaman Seni izliyorum...",
                Notch = "Minecraft benim sayemde kuruldu"
            },

            Wiki = new TWiki
            {
                Blocks = "Blok",
                Unknown = "Bulunamadi",
                Player = "Oyuncu",
                Players = "Oyuncular",
                Attack = "Saldırı",
                Easy = "Kolay",
                Hard = "Zor",
                Health = "sağlık",
                Height = "Yukseklik",
                Width = "Genişlik"
            },

            Profile = new TProfile
            {
                Badges = "Başarım",
                BadgeInfo = "Başarım bilgilendirmesi",
                InvalidUserID = "kullanici id si bulunamadi",
                UnknownUser = "Kullanıcı bulunamadı",
                NotInServer = "Sen bir server degilsin",
                SetMCName = "Minecraft Hesabini kullanman için"
            },

            Admin = new TAdmin
            {
                Commands = new List<string>
                {
                    "[ mc/lang ]( topluluk dilini değiştir )",
                    "[ mc/mcrole ]( minecraft hesabini dogrulayanlar için özel rol yapar )",
                    "[ mc/addserver ]( mc serverini eklemene yarar )",
                    "[ mc/delserver ]( mc serverini silmene yarar )",
                    "[ mc/setprefix ]( istedigin bir prefixi ayarlar )",
                    "[ mc/resetprefix ]( istedigin prefixi siler )"
                },
                WantTranslation = "Çevirilen bir dil mi istiyorsunuz? Ulas",
                ChangeLang = "Topluluk dilini değiştir",
                UseList = "Kullan mc/list bu bottaki sunuculari gormek için",
                AddServer = "tag gir, ip ve isim",
                AddServerAdded = "server eklendi {0} guild listesine bak",
                AddServerAlready = "Bu sunucu zaten listede",
                DelServerEnter = "bir sunucu sil",
                DelServerNone = "Bu sunucu listede yok",
                DelServerDeleted = "Server silindi {0} Guild listesine bak",
                PrefixReset = "Server prefix yenilendi kullan mc/",
                LanguageSet = "topluluk dili yenilendi"
            }
        };
    }
}
