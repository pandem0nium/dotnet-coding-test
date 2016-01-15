using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ToDo.Entity
{
    public class ToDoItem : IToDoItem
    {
        private string _id;
        private string _title;
        private string _description;
        private bool _complete;
        private string _parent_task_id;
        

        public string Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Title
        {
            get { return _title; }
            set { _title = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string Parent_task_id
        {
            get { return _parent_task_id; }
            set { _parent_task_id = value; }
        }

        public bool Complete
        {
            get { return _complete; }
            set { _complete = value; }
        }
    }
}
