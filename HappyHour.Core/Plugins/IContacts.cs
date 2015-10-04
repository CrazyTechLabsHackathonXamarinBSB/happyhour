using HappyHour.Core.Models;
using System.Collections.Generic;

namespace HappyHour.Core.Plugins
{
    /// <summary>
    /// Interface para contatos dos SOS
    /// </summary>
    public interface IContacts
    {
        List<GenericContact> GetContacts();
    }
}
