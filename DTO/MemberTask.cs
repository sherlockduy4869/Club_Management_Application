using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_OOP_Final.DTO
{
    public class MemberTask
    {
        private string _id;
        private string _taskId;
        private string _task;
        private string _deadline;
        private string _status;
        public MemberTask(DataRow row)
        {
            _id = (string)row["Id"];
            _taskId = (string)row["Task_Id"];
            _task = (string)row["Task"];
            _deadline = (string)row["Deadline"];
            _status = (string)row["Status"];
        }
        public MemberTask(string id, string taskId, string task, string deadline, string status)
        {
            _id = id;
            _taskId = taskId;
            _task = task;
            _deadline = deadline;
            _status = status;
        }
        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public string TaskId
        {
            get { return _taskId; }
            set { _taskId = value; }
        }
        public string Task
        {
            get { return _task; }
            set { _task = value; }
        }
        public string Deadline
        {
            get { return _deadline; }
            set { _deadline = value; }
        }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
