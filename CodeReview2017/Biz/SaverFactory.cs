using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview.Biz
{
    public class SaverFactory
    {
        public static ISaveReview GetSaver() {
            return new SaveTxtRecord();
        }
    }
}
