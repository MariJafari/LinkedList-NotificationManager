using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Q2_WinForm
{
    public class SubscriptionManager
    {
        // Events to be raised when a subscription is added or removed
        public event EventHandler<NotificationEventArgs> SubscriptionAdded;
        public event EventHandler<NotificationEventArgs> SubscriptionRemoved;

        // Lists to store email and SMS subscribers
        private List<string> emailSubscribers = new List<string>();
        private List<string> smsSubscribers = new List<string>();

        // Adds a subscriber. If email or phone, it validates and then adds to the list.
        public void AddSubscriber(string email, string phoneNumber)
        {
            bool emailAdded = false, phoneNumberAdded = false;

            if (!string.IsNullOrEmpty(email))
            {
                if (!IsValidEmail(email))
                {
                    throw new ArgumentException("Invalid email address.");
                }
                if (emailSubscribers.Contains(email))
                {
                    throw new ArgumentException("Duplicate email address.");
                }
                emailSubscribers.Add(email);
                emailAdded = true;
            }

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                if (!IsValidPhoneNumber(phoneNumber))
                {
                    throw new ArgumentException("Invalid phone number.");
                }
                if (smsSubscribers.Contains(phoneNumber))
                {
                    throw new ArgumentException("Duplicate phone number.");
                }
                smsSubscribers.Add(phoneNumber);
                phoneNumberAdded = true;
            }

            if (emailAdded)
            {
                SubscriptionAdded?.Invoke(this, new NotificationEventArgs { Email = email });
            }
            if (phoneNumberAdded)
            {
                SubscriptionAdded?.Invoke(this, new NotificationEventArgs { PhoneNumber = phoneNumber });
            }
        }

        // Removes a subscriber from the list.
        public void RemoveSubscriber(string email, string phoneNumber)
        {
            if (!string.IsNullOrEmpty(email))
            {
                if (emailSubscribers.Remove(email))
                {
                    SubscriptionRemoved?.Invoke(this, new NotificationEventArgs { Email = email });
                }
                else
                {
                    throw new ArgumentException("Email address not found in subscribers.");
                }
            }

            if (!string.IsNullOrEmpty(phoneNumber))
            {
                if (smsSubscribers.Remove(phoneNumber))
                {
                    SubscriptionRemoved?.Invoke(this, new NotificationEventArgs { PhoneNumber = phoneNumber });
                }
                else
                {
                    throw new ArgumentException("Phone number not found in subscribers.");
                }
            }
        }

        // Checks if there are any subscribers.
        public bool HasSubscribers()
        {
            return emailSubscribers.Any() || smsSubscribers.Any();
        }

        // Validates an email address with a simple regex pattern.
        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        // Validates a phone number with a simple regex pattern (assuming US format).
        private bool IsValidPhoneNumber(string number)
        {
            return Regex.IsMatch(number, @"^\d{10}$");
        }

        public List<string> GetAllSubscribers()
        {
            // Combine both lists and return
            return emailSubscribers.Concat(smsSubscribers).ToList();
        }
    }
}