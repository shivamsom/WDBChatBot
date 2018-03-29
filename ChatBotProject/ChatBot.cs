using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WDB
{
    public partial class ChatBot
    {
        const string UserId = "szabist";


        public ChatBot()
        {
            //AimlBot = new Bot();
            //myUser = new User(UserId, AimlBot);
            //Initialize();
        }
       
        
       
       
            
            //  Loads all the AIML files in the \AIML folder         
        public void Initialize()
        {
            //    AimlBot.loadSettings();
            //    AimlBot.isAcceptingUserInput = false;
            //    AimlBot.loadAIMLFromFiles();
            //    AimlBot.isAcceptingUserInput = true;
            //
        }

        // Given an input string, finds a response using AIMLbot lib
        public String getOutput(String input)
        {

            // Luis
            // Webclient Intent ->cooking

            //Request r = new Request(input, myUser, AimlBot);
            //Result res = AimlBot.Chat(r);
            return "BIMBO";
        }
    }
}
