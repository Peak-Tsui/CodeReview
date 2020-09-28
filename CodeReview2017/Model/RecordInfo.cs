using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeReview.Model
{
    public class RecordInfoModel
    {
        public string MethodName { get; set; }
        public string SelectedCode { get; set; }
        public string Question { get; set; }
        public string Suggestion { get; set; }
        /// <summary>
        /// 修复人
        /// </summary>
        public string Engineer { get; set; }
        public DateTime PlanCloseDate { get; set; }
        public int CodeLineNumber { get; set; }
        public string ProjectName { get; set; }
        public string FileFullPath { get; set; }
    }
}
