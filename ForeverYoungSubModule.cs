//same as before, call everything you need to use
using TaleWorlds.CampaignSystem;
using TaleWorlds.Core;
using TaleWorlds.MountAndBlade;

namespace ForeverYoung
{
	public class ForeverYoungSubModule : MBSubModuleBase
	{
		//load the module
		protected override void OnSubModuleLoad()
		{
		}
		//set when to load the module
		protected override void OnGameStart(Game game, IGameStarter gameStarterObject)
		{
			//make sure the game is a Campaign mode
			if (!(game.GameType is Campaign))
				return;
			//load the class MUST BE SAME NAMESPACE
			gameStarterObject.AddModel(new ForeverYoungModel());
		}
	}
}
