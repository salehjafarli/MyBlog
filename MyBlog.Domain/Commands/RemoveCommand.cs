﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBlog.Domain.Commands
{
    public abstract class RemoveCommand : ICommand
    {
        public int Id { get; set; }
    }
}
