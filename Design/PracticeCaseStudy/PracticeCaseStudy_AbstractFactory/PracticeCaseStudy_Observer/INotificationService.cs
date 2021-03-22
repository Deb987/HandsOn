using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeCaseStudy_Observer
{
    public interface INotificationService
    {
        void AddSubscriber(INotificationObserver observer);
        void RemoveSubscriber(INotificationObserver observer);
        void NotifySubscriber();
    }
}
