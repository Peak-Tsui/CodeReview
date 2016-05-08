using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeReview.Model;

namespace CodeReview.Biz
{
    public class SaveTxtRecord : ISaveReview
    {
        public void Save(RecordInfoModel model)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("[时间]\t" + DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"));
            sb.Append(System.Environment.NewLine);

            sb.Append("[组件]\t" + model.ProjectName);
            sb.Append(System.Environment.NewLine);
            sb.Append("[文件]\t" + model.FileFullPath);
            sb.Append(System.Environment.NewLine);
            sb.Append("[行号]\t" + model.CodeLineNumber);
            sb.Append(System.Environment.NewLine);
            sb.Append("[方法]\t" + model.MethodName);
            sb.Append(System.Environment.NewLine);
            sb.Append("[代码]\t" + model.SelectedCode);
            sb.Append(System.Environment.NewLine);
            sb.Append("[问题]\t" + model.Question);
            sb.Append(System.Environment.NewLine);
            sb.Append("[建议]\t" + model.Suggestion);
            sb.Append("[修改人]:" + model.Engineer);
            sb.Append("\t[计划修改时间]:" + model.PlanCloseDate.ToString("yyyy-MM-dd"));
            sb.Append(System.Environment.NewLine);
            sb.Append("-----------------------------------------------------------------------------------------");
            sb.Append(System.Environment.NewLine);

            string fileName = "CodeReview_" + DateTime.Now.ToString("yyyy-MM-dd") + ".txt";
            string fullName = "E:\\temp\\" + fileName;
            if (!System.IO.File.Exists(fullName))
            {
                System.IO.File.Create(fullName).Close();
            }
            using (System.IO.TextWriter wr = new System.IO.StreamWriter(fullName, true))
            {
                wr.Write(sb.ToString());
            }
        }
    }
}
