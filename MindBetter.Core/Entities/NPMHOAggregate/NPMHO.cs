﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MindBetter.Core.Entities.NPMHOAggregate
{
    public class NPMHO : BaseEntity
    {
        public string? Email { get; protected set; }

        public string? Website { get; protected set; }

        public List<NPMHOMember> Members { get; set; }

        public List<Service> Services { get; set; }

        public NPMHO(int id, string name, string? email, string? website) : base(id, name)
        {
            Email = email;
            Website = website;
            Members = new List<NPMHOMember>();
            Services = new List<Service>();
        }
    }
}
