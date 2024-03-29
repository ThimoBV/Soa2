﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Notifications.Interfaces;

namespace Domain.Roles
{
    public abstract class User(string name, string email, string password) : ISubscriber
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string Name { get; set; } = name;
        public string Email { get; set; } = email;
        public string Password { get; set; } = password;
        public List<IPublisher> Preferences { get; set; } = new();
        public virtual void Notify()
        {
            foreach (var preference in Preferences)
            {
                preference.SendNotification($"notification send to: {this.Email}");
            }
        }

        public void AddPreferences(IPublisher preference)
        {
            Preferences.Add(preference);
        }
    }
}
