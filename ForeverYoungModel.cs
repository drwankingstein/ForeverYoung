//Call out the DLL you mean to edit
using TaleWorlds.CampaignSystem;
//Call out the namespace
using TaleWorlds.CampaignSystem.SandBox.GameComponents;
//Call Out DLL Just put it in every module for safety
using TaleWorlds.Core;
//Name space lets files interact with eachother easily and used for sorting
namespace ForeverYoung

{
    //this Makes a Class and inherits DefaultAgeModel
	public class ForeverYoungModel : DefaultAgeModel
	{
        //overrides the settings
    public override int BecomeInfantAge
    {
      get
      {
       //sets the value
        return 3;
      }
    }

    public override int BecomeChildAge
    {
      get
      {
        return 124;
      }
    }

    public override int BecomeTeenagerAge
    {
      get
      {
        return 125;
      }
    }

    public override int HeroComesOfAge
    {
      get
      {
        return 126;
      }
    }

    public override int BecomeOldAge
    {
      get
      {
        return 127;
      }
    }

    public override int MaxAge
    {
      get
      {
        return 128;
      }
    }
	}
}
