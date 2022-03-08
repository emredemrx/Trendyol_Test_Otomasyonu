using System;
using TestOtomasyon.Entities;
namespace TestOtomasyon.Model
{
    public class LogAdd
    {
        LogData log = new LogData();
        public void Add(string levelTxt,string processTxt,string message,string exception)
        {
            var time = DateTime.Now.ToString("O");
            using (DataContext context = new DataContext())
            {
                log.Data = time;
                log.Level = levelTxt;
                log.Process = processTxt;
                log.Message = message;
                log.Exception = exception;
                context.LogSave.Add(log);
                context.SaveChanges();
            }
        }

    }
}
