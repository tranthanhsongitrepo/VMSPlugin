using Newtonsoft.Json;
using System;
using Dapper;
using System.Collections.Generic;
using System.Data;
using VMSPlugin.Model;

namespace VMSPlugin.Repository
{
    public class JsonROITypeHandler : SqlMapper.ITypeHandler
    {
        public void SetValue(IDbDataParameter parameter, object value)
        {
            parameter.Value = JsonConvert.SerializeObject(value);
        }

        public object Parse(Type destinationType, object value)
        {
            return JsonConvert.DeserializeObject(value as string, destinationType);
        }
    }

    class CameraRepository : Repository<Camera>
    {
        public CameraRepository()
        {
            SqlMapper.AddTypeHandler(typeof(List<ROI>), new JsonROITypeHandler());
        }
        public override void Create()
        {
            throw new NotImplementedException();
        }

        public override Camera GetById(object id)
        {
            Camera camera =  Conn.QueryFirstOrDefault<Camera>("SELECT * FROM channel_settings WHERE channel_id = @channel_id", new { channel_id = id.ToString() });
            return camera;
        }

        public override void RemoveById(object id)
        {
            throw new NotImplementedException();
        }

        public void Save(Camera camera)
        {
            string json = JsonConvert.SerializeObject(camera.ActiveROIs);
            Conn.Execute("INSERT INTO channel_settings(channel_id, channel_name, va_server_idx, connection_state, active_rois)" +
                "VALUES (@cam_id, @cam_name, @va_server_idx, @conn_state, @parameters)",
                new { cam_id = camera.ChannelID, cam_name = camera.ChannelName, va_server_idx = camera.VAServerIdx,
                    conn_state = camera.ConnectionState, parameters = json });
        }

    }
}
