// =======================================================================================
// Maintained by bobatea#9400 on Discord
// Usable for both personal and commercial projects, but no sharing or re-sale
// * Discord Support Server.............:  
  
// * Leave a star on my Github Repo.....: https://github.com/breehuynh/Bree-mmorpg-tools
// * Instructions.......................: https://indie-mmo.net/knowledge-base/
// =======================================================================================
using System.Linq;

// ENTITY

public partial class Entity
{
    public bool _healthRecovery = true; // can be disabled in combat etc.

    // -----------------------------------------------------------------------------------
    // healthRecovery
    // -----------------------------------------------------------------------------------
    public virtual bool healthRecovery
    {
        get
        {
#if _iMMOBUFFBLOCKHEALTHRECOVERY
            return healthRecoveryRate < 0 || (_healthRecovery && !buffs.Any(x => x.blockHealthRecovery));
#else
			return _healthRecovery;
#endif
        }
    }

    // -----------------------------------------------------------------------------------
}
