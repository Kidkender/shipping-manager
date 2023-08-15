using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLVNNhaNam.Class
{
    public class EnumField
    {
        public const string DaHuyDon = "Đã hủy đơn";
        public const string DaNhanDon = "Đã nhận hàng";
        public const string DoiHuyDon = "Đang được đổi đơn hàng";
        public const string TraDon = "Đang được trả đơn hàng";
        public const string KhieuNaiDon = "Đang được khiếu nại";

        // Message
        public const string MessageHuyDon = "Bạn có muốn xác nhận hủy đơn hàng?";
        public const string MessageNhanDon = "Bạn có muốn xác nhận đơn hàng?";
    }
}
