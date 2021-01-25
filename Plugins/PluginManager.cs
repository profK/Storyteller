using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Plugins
{
    public class PluginManager
    {
        static private PluginManager _instance;
        static public PluginManager Instance {
            get
            {
                if (_instance == null)
                {
                    _instance = new PluginManager();
                }
                return _instance;
            } 
        }

        public Dictionary<Type, List<IPlugin>> _store = new Dictionary<Type, List<IPlugin>>();

        private PluginManager() { } //hide

        public void AddPlugin(Type type)
        {
            IPlugin pinst = Activator.CreateInstance(type) as IPlugin;
            foreach(var iface in type.GetInterfaces())
            {
                if (!_store.ContainsKey(iface))
                {
                    _store.Add(iface,new List<IPlugin>());
                }
                _store[iface].Add(pinst);
            }
        }

        public T GetPlugin<T>() where T:IPlugin
        {
            
            if (_store.ContainsKey(typeof(T))){

                return (T)_store[typeof(T)][0];   
            } else
            {
                return default(T);
            }
        }

        public T[] GetAllPlugins<T>() where T : IPlugin
        {

            if (_store.ContainsKey(typeof(T)))
            {

                return _store[typeof(T)].OfType<T>().ToArray();
            }
            else
            {
                return default(T[]);
            }
        }
    }
}
