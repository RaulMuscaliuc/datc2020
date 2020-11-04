
using System;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Host;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using students-api.Student;

namespace DATC2020.Students
{
    public static class QueueTriggerLab06
    {
        [FunctionName("QueueTriggerLab06")]
        [return: Table("students")]
        public static Student Run([QueueTrigger("student-queue", Connection = "storageaccountdatc2a7f4_STORAGE")]string myQueueItem, ILogger log)
        {
            var student = JsonConvert.DeserializeObject<Student>(myQueueItem);

            return student;
        }
    }
}
