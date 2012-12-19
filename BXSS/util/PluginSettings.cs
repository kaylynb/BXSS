﻿namespace util
{
    using System.Linq;
    using System.Reflection;
    using KSP.IO;

    public abstract class PluginSettings<TPluginType>
    {
        private readonly PluginConfiguration _kspPluginConfiguration;

        private readonly MethodInfo _getValueMethod;

        protected PluginSettings()
        {
            _kspPluginConfiguration = PluginConfiguration.CreateForType<TPluginType>();
            _getValueMethod = typeof (PluginConfiguration).GetMethods()
                                                         .First(y => y.Name == "GetValue" && y.GetParameters().Count() == 2);
        }

        public void Load()
        {
            foreach (var x in GetType().GetProperties())
            {
                _kspPluginConfiguration.load();

                var getValueMethodGeneric = _getValueMethod.MakeGenericMethod(new[] {x.PropertyType});
                x.GetSetMethod().Invoke(this, new[] {getValueMethodGeneric.Invoke(_kspPluginConfiguration, new[] {x.Name, x.GetGetMethod().Invoke(this, null)})});
            }
        }

        public void Save()
        {
            foreach (var x in GetType().GetProperties()
                .Select(x => new
                                 {
                                     x.Name,
                                     Value = x.GetGetMethod().Invoke(this, null)
                                 }))
            {
                _kspPluginConfiguration.SetValue(x.Name, x.Value);
            }

            _kspPluginConfiguration.save();
        }
    }
}