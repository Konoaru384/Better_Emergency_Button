using System.Collections.Generic;
using System.ComponentModel;
using Exiled.API.Interfaces;
using PlayerRoles;

namespace EmergencyButtonRestrictor
{
    public class Config : IConfig
    {
        public bool IsEnabled { get; set; } =  true;
        public bool Debug { get; set; } =  false;
        /// <summary>
        /// BlacklistRole : List roles cant use Button
        /// </summary>
        [Description("Blackliste roles")]
        public List<RoleTypeId> BlacklistedRoles { get; set; } = new List<RoleTypeId>
        {
            RoleTypeId.Scp173,
            RoleTypeId.Scp049,
            RoleTypeId.Scp106,
            RoleTypeId.Scp096,
            RoleTypeId.Scp939,
            RoleTypeId.Scp3114
        };
        /// <summary>
        /// Broadcast Message in Game
        /// </summary>
        [Description("Broadcast message")]
        public string DeniedBroadcastMessage { get; set; } = "<color=#C50000>You are not authorized to use the emergency release button!</color>";
        /// <summary>
        /// Duration Time Broadcast => 5s
        /// </summary>
        [Description("Broadcast message time duration")]
        public ushort DeniedBroadcastDuration { get; set; } = 5;
        /// <summary>
        /// Hint message for can use button again :)
        /// </summary>
        [Description("Ready use hint")]
        public string ReadyUseButton {get; set;} = "<color=#C50000>Ready For use again</color>";
        /// <summary>
        /// Duration Time Hint => 5s
        /// </summary>
        [Description("Ready use hint duration time")]
        public ushort ReadyUseDuration { get; set; } = 5;
    }
}