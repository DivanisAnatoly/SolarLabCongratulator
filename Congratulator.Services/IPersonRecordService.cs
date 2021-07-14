﻿using Congratulator.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Congratulator.Services
{
    public interface IPersonRecordService
    {
        IEnumerable<Person> GetPeople();

        Person GetPerson(int? id);

        void AddPerson(Person newPerson);

        void UpdatePerson(Person updPerson);

        void RemovePerson(Person delPerson);

        IEnumerable<Person> GetBirthdayPeople();

        IEnumerable<Person> GetSoonBirthdayPeople(int daysInterval=30);


    }
}