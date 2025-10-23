using System.Collections.Generic;
using Exiled.API.Features;
using Exiled.Events.EventArgs.Player;
using PlayerRoles;
using System;


namespace EmergencyButtonRestrictor
{
    public class Plugin : Plugin<Config>
    {
        public override string Name => "EmergencyButtonRestrictor";
        public override string Author => "Konoara";
        public override string Prefix => "emergency_button_restrictor";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredExiledVersion => new Version(9, 10, 0);

        public override void OnEnabled()
        {
            Exiled.Events.Handlers.Player.InteractingEmergencyButton += OnInteractingButton;
            base.OnEnabled();
        }

        public override void OnDisabled()
        {
            Exiled.Events.Handlers.Player.InteractingEmergencyButton -= OnInteractingButton;
            base.OnDisabled();
        }

        private void OnInteractingButton(InteractingEmergencyButtonEventArgs ev)
        {
            if (ev.Player == null) return;
            if (Config.BlacklistedRoles.Contains(ev.Player.Role.Type))
            {
                ev.IsAllowed = false;
                if (!string.IsNullOrEmpty(Config.DeniedBroadcastMessage))
                {
                    ev.Player.Broadcast(Config.DeniedBroadcastDuration, Config.DeniedBroadcastMessage, Broadcast.BroadcastFlags.Normal, true);
                }
            }
        }
    }

    public class Config : Exiled.API.Interfaces.IConfig
    {
        public bool IsEnabled { get; set; } = true;
        public bool Debug { get; set; } = false;

        public List<RoleTypeId> BlacklistedRoles { get; set; } = new List<RoleTypeId>
        {
            RoleTypeId.Scp173,
            RoleTypeId.Scp049,
            RoleTypeId.Scp106,
            RoleTypeId.Scp096,
            RoleTypeId.Scp939,
            RoleTypeId.Scp3114
        };

        public string DeniedBroadcastMessage { get; set; } = "<color=red>You are not authorized to use the emergency release button!</color>";
        public ushort DeniedBroadcastDuration { get; set; } = 5;
    }
}

