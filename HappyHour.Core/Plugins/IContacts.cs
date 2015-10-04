using HappyHour.Core.Models;
using System.Collections.Generic;

namespace HappyHour.Core.Plugins
{
    public interface IContacts
    {
        List<GenericContact> GetContacts();
    }
}
