using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TDVLesson06.Models;

namespace TDVLesson06.Controllers
{
    public class TDVSongController : Controller
    {
        private static List<TDVSong> tdvSongs = new List<TDVSong>()
        {
            new TDVSong{Id=2210900138,TDVTitle="Tran Duy Vu",TDVAuthor="K22CNT3",TDVArtist="NTU",TDVYearRelease=2020},
            new TDVSong{Id=1,TDVTitle="Tran Duy Vu",TDVAuthor="K22CNT3",TDVArtist="NTU",TDVYearRelease=2020},
        };
        // GET: TDVSong
        /// <summary>
        /// Hien thi danh sach bai hat
        /// Author: Tran Duy Vu
        /// </summary>
        /// <returns></returns>
        public ActionResult TDVIndex()
        {
            return View(tdvSongs);
        }

        //Get: TDVCreate
        /// <summary>
        /// Form them moi bai hat
        /// Author: Tran Duy Vu
        /// </summary>
        /// <returns></returns>
        public ActionResult TDVCreate()
        {
            var tdvSong = new TDVSong();
            return View(tdvSong);
        }
    }
}