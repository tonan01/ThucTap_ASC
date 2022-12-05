using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Net;
using System.Web;
using System.Web.Mvc;
using ThucTap.KenDo.MediaPlayer.Models;
using Kendo.Mvc.UI;
using System.Web.UI.WebControls;
using Kendo.Mvc.Resources;
using System.Threading;
using System.Web.Security;
using System.Security.Policy;
using System.Drawing;
using Kendo.Mvc.Extensions;
using ThucTap.KenDo.MediaPlayer.ViewModel;
namespace ThucTap.KenDo.MediaPlayer.Controllers
{
    public class HomeController : Controller
    {
        
        #region Show video Cơ Bản
        public ActionResult Basic_Usage()
        {
            return View();
        }
        #endregion

        #region Media event
        public ActionResult EventMedia()
        {
            return View();
        }
        #endregion

        #region Sử dụng phím tắt Media
        public ActionResult Keyboard_Media()
        {
            return View();
        }
        #endregion

        #region API
        public ActionResult Api()
        {
            return View();
        }
        #endregion

        #region Playlist Media
        public ActionResult Playlist()
        {
            return View(GetVideos());
        }

        public ActionResult Videos_Read([DataSourceRequest] DataSourceRequest request)
        {
            return Json(GetVideos().ToDataSourceResult(request));
        }

        private  IEnumerable<Video> GetVideos()
        {
            ThucTapMediaDataContext db = new ThucTapMediaDataContext();
            List<Video> videos = new List<Video>();
            var listVideo = db.sp_Video();
            foreach(var item in listVideo)
            {
                videos.Add(new Video()
                {
                    title = item.Title,
                    poster = item.Poster,
                    source = item.Source,
                });
            }    
            return videos;
        }
        #endregion

        #region Configuration
        ////Object

        //media Object( media.source,   media.title   )
        //Đối tượng nắm giữ thông tin về phương tiện sẽ được điều khiển phát.
        //------------------------------------
        //media.source String
        //Chuỗi hoặc một mảng đối tượng giữ URL hoặc nhiều URL của video.
        //------------------------------------
        //media.title String
        //Chỉ định tiêu đề của phương tiện sẽ được phát.

        //----------------------------------------------------------------

        //messages Object (messages.pause, messages.play, messages.mute, messages.unmute, messages.quality)
        //Đối tượng chứa các chuỗi bản địa hóa.
        //------------------------------------
        //messages.pause String
        //Thông báo chú giải công cụ của nút tạm dừng.
        //------------------------------------
        //messages.play String
        //Thông báo chú giải công cụ của nút phát.
        //------------------------------------
        //messages.mute String
        //Nút tắt thông báo chú giải công cụ.
        //------------------------------------
        //messages.unmute String
        //Bật âm thanh thông báo chú giải công cụ của nút.
        //------------------------------------
        //messages.quality String
        //Thông báo chú giải công cụ nút chất lượng.
        //------------------------------------
        //messages.fullscreen String
        //Thông báo chú giải công cụ của nút toàn màn hình.

        //------------------------------------------------------------------------------------------------------------
        ////Mặc định false

        //autoPlay Boolean(default: false)
        //Nếu được đặt thành true, tiện ích sẽ bắt đầu phát video hoặc các video sau khi khởi chạy.
        //------------------------------------
        //autoRepeat Boolean(default: false)
        //Nếu được đặt thành true, tiện ích sẽ bắt đầu phát video hoặc các video sau khi khởi chạy.
        //------------------------------------
        //fullScreen Boolean(default: false)
        //Nếu được đặt thành true, tiện ích con sẽ chuyển sang chế độ toàn màn hình.
        //------------------------------------
        //mute Boolean (default: false)
        //Nếu được đặt thành true, video sẽ được phát mà không có âm thanh.
        //------------------------------------
        //navigatable Boolean (default: false)
        //Nếu được đặt thành true, tùy chọn sẽ bật điều hướng bàn phím cho tiện ích con.

        //------------------------------------------------------------------------------------------------------------
        ////Mặc định true

        //forwardSeek Boolean(default: true)
        //Nếu được đặt thành false, người dùng sẽ bị ngăn không cho chuyển tiếp video.

        //------------------------------------------------------------------------------------------------------------
        ////Giá trị

        //volume Number(default: 100)
        //giá trị từ 0 đến 100 chỉ định âm lượng của video.

        #endregion

        #region Methods
        //fullScreen Boolean
        //media Object
        //volume Number
        //mute Boolean
        //isEnded Boolean   Nhận giá trị cho biết phương tiện đã phát xong chưa.
        //isPaused Boolean Nhận giá trị cho biết phương tiện bị tạm dừng, dừng hay kết thúc.
        //isPlaying Boolean Nhận một giá trị cho biết phương tiện hiện đang phát hay không.

        //pause Boolean Hiện tại Tạm dừng 
        //play Boolean buộc Chạy
        //seek Number    Tiếp tục video đến một thời điểm nhất định.
        //stop Dừng video hiện đang phát.
        //titlebar jQuery Nhận tham chiếu đến thanh tiêu đề.
        //toolbar kendo.ui.ToolBar Nhận tham chiếu đến thanh công cụ.
        #endregion

        #region Events
        //end
        //Cháy khi phương tiện phát xong. Ngữ cảnh của hàm xử lý sự kiện (có sẵn thông qua từ khóa this) sẽ được đặt thành phiên bản widget

        //pause
        //Cháy khi phương tiện bị tạm dừng. Ngữ cảnh của hàm xử lý sự kiện(có sẵn thông qua từ khóa this) sẽ được đặt thành phiên bản widget

        //play
        //Cháy khi phương tiện bắt đầu phát. Ngữ cảnh của hàm xử lý sự kiện(có sẵn thông qua từ khóa this) sẽ được đặt thành phiên bản widget

        //ready
        //Kích hoạt khi quá trình tải kết thúc và tiện ích con đã sẵn sàng để bắt đầu phát phương tiện.
        //Ngữ cảnh của hàm xử lý sự kiện(có sẵn thông qua từ khóa this) sẽ được đặt thành phiên bản widget.

        //timeChange
        //Kích hoạt khi người dùng chọn thời gian chơi mới. Ngữ cảnh của hàm xử lý sự kiện(có sẵn thông qua từ khóa this) sẽ được đặt thành phiên bản widget.

        //volumeChange
        //Sự kiện này được kích hoạt khi thay đổi mức âm lượng. Ngữ cảnh của hàm xử lý sự kiện(có sẵn thông qua từ khóa this) sẽ được đặt thành phiên bản widget.

        ////ví dụ
        //play: function()
        //{
        //    //handle event
        //}
        #endregion
    }
}