﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstAndReserveTeam
{
    class Team
    {
        private string name;
        private List<Person> firstTeam;
        private List<Person> reserveTeam;

        public Team(string name)
        {
            this.Name = name;
            this.firstTeam = new List<Person>();
            this.reserveTeam = new List<Person>();
        }

        public string Name
        {
            get { return this.name; }
            private set { this.name = value; }
        }

        public IReadOnlyList<Person> FirstTeam
        {
            get => this.firstTeam.AsReadOnly();
        }
        public IReadOnlyList<Person> ReserveTeam
        {
            get => this.reserveTeam.AsReadOnly();
        }

        public void AddPlayer(Person player)
        {
            if(player.Age < 40)
            {
                this.firstTeam.Add(player);
            }
            else
            {
                this.reserveTeam.Add(player);
            }
        }
    }
}
