using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview.Biz
{
    public interface ISaveReview
    {
        void Save(Model.RecordInfoModel model);
    }
}
