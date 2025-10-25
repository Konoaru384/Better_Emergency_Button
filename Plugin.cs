using System;
using Exiled.Events.EventArgs.Player;
using Exiled.API.Features;


namespace EmergencyButtonRestrictor
{
    public class Plugin : Plugin<Config>
    {
        public override string Name { get; } = "EmergencyButtonRestrictor";
        public override string Author { get; } = "Konoara";
        public override string Prefix { get; } = "emergency_button_restrictor";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredExiledVersion { get; } = new Version(9, 10, 0);

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
            
            if (ev.EmergencyReleaseButton.IsReady)
            {
                ev.Player.ShowHint(Config.ReadyUseButton , Config.ReadyUseDuration);
            }
        }
    }

}
