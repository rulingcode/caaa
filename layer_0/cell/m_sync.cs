using LiteDB;
using Newtonsoft.Json;
using System;
using System.ComponentModel;
using System.Linq;
using System.Reflection;

namespace layer_0.cell
{
    public abstract class m_sync : m_id, INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        [BsonIgnore] [JsonIgnore] public abstract string z_xid { get; }
        [BsonIgnore] [JsonIgnore] public virtual e_permission z_permission { get; } = e_permission.u;
        public void z_copy(m_sync val)
        {
            if (id != val.id)
                throw new Exception("fkvkgknjgibjfjvhdjfk");
            foreach (PropertyInfo property in GetType().GetProperties().Where(i => i.CanWrite))
            {
                if (property.Name == "id")
                    continue;
                property.SetValue(this, property.GetValue(val));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(property.Name));
            }
        }
    }
}