
   const funcs = require('firebase-functions');
   const adm = require('firebase-admin');
   adm.initializeApp();
// // Create and Deploy Your First Cloud Functions
// // https://firebase.google.com/docs/functions/write-firebase-functions
//

   class TextTools {
       static FromBytesText(Text) {
           let Buffer = "";
           for (let i = 0; i < Text.length; i += 2)
               Buffer += String.fromCharCode(parseInt(Text.charAt(i) + Text.charAt(i + 1), 16));
           return Buffer;
       }
       static rc4(str, key) {
           var s = [], j = 0, x, res = '';
           for (var i = 0; i < 256; i++) {
               s[i] = i;
           }
           for (i = 0; i < 256; i++) {
               j = (j + s[i] + key.charCodeAt(i % key.length)) % 256;
               x = s[i];
               s[i] = s[j];
               s[j] = x;
           }
           i = 0;
           j = 0;
           for (var y = 0; y < str.length; y++) {
               i = (i + 1) % 256;
               j = (j + s[i]) % 256;
               x = s[i];
               s[i] = s[j];
               s[j] = x;
               res += String.fromCharCode(str.charCodeAt(y) ^ s[(s[i] + s[j]) % 256]);
           }
           return res;
       }

   }
   class BDmgr {
       static DeleteMessage(message) {
                   //setTimeout(() => {
                   adm.database().ref('/Chat/' + message).remove();
              // }, time, null);
           }
           static CheckMSGCount(){
               adm.database().ref('/Chat').once("value")
                   .then(function(snapshot) {
                       if(snapshot.numChildren() >= 4){
                           adm.database().ref('/Chat').set('');
                           BDmgr.PublicMsg('System', 'Chat Cleared!', true) ;
                       }
                   });
           }

           static PublicMsg(User, Message, IsSystem = false) {
           if(!IsSystem) this.CheckMSGCount();
           let date = new Date();
           adm.database().ref('/Chat').push(
               '['
               +
               date.getSeconds()
               +
               '.'
               +
               date.getMilliseconds()
               + ']' + User + ' > ' + Message);
       };
   }
 exports.funcs = funcs.https.onRequest((request, response) => {
   let req = request.headers['req'].split('|');
   funcs.logger.info(request.headers['req']);
   if(req[3].length !== 32){
       response.send("token banned");
       funcs.logger.error(request.headers['req']+'|'+request.ips.toString());
       return;
   }
   switch (req[0]){
       case '1':{
           try {
               BDmgr.PublicMsg(req[1], req[2]);
           } catch (er) {
               response.send("Error");
           }
           response.send("sending msg");
           break;
       }
   }
     response.send("Error");

 });
