using Destiny.Maple.Characters;
using Destiny.Maple.Maps;
using System;
using static Destiny.Constants.CharacterConstants;

namespace Destiny.Maple.Scripting
{
    public sealed class PortalScript : ScriptBase
    {
        private Portal mPortal;

        public PortalScript(Portal portal, Character character)
            : base(ScriptType.Portal, portal.Script, character, false)
        {
            mPortal = portal;

            this.Expose("playPortalSe", new Action(this.PlayPortalSoundEffect));
            this.Expose("showBalloonMessage", new Action<string, short, short>(this.ShowBalloonMessage));
        }

        private void PlayPortalSoundEffect()
        {
            CharacterBuffs.ShowLocalUserEffect(mCharacter, UserEffect.PlayPortalSE);
        }

        private void ShowBalloonMessage(string hint, short width, short height)
        {
            mPortal.ShowBalloonMessage(mCharacter, hint, width, height);
        }
    }
}