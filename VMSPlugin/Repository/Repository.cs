using MySqlConnector;
using VAPlugin;
using Dapper;
using System.Data;
using System;

namespace VMSPlugin.Repository
{
    public class GuidTypeHandler : SqlMapper.ITypeHandler
    {
        public void SetValue(IDbDataParameter parameter, object value)
        {
            parameter.Value = value.ToString();
        }

        public object Parse(Type destinationType, object value)
        {
            return new Guid(value.ToString());
        }
    }
    public abstract class Repository<T>
    {
        protected MySqlConnection Conn { get; set; }
        public Repository()
        {
            Init();
            Dapper.DefaultTypeMap.MatchNamesWithUnderscores = true;
            SqlMapper.AddTypeHandler(typeof(Guid), new GuidTypeHandler());

        }

        public abstract T GetById(object id);

        public abstract void RemoveById(object id);

        public abstract void Create();

        // public abstract void Update(string id);

        public void Init()
        {
            Conn = VMSPluginDefinition.Connection;
        }


    }
}
