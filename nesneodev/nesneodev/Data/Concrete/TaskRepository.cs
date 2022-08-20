using nesneodev.Data.Abstract;
using nesneodev.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace nesneodev.Data.Concrete
{
    public class TaskRepository:GenericRepoistory<Task,DataContext>,ITaskRepository
    {
        //bu kısım ekstra ozellikler için kullanılacak
    }
}
