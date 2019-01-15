using System;
using System.Threading.Tasks;
using Five.QuartzNetJob.Utils.Tool;
using Quartz;

namespace Five.QuartzNetJob.ExecuteJobTask.Service
{
    public class HelloJob:IJob
    {
        public Task Execute(IJobExecutionContext context)
        {
            Console.Out.WriteLineAsync("Greetings from HelloJob!");
           // Log4netHelper.Info("Greetings from HelloJob!");
            return Task.CompletedTask;
        }
    }
}