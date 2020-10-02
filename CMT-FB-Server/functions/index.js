
   const funcs = require('firebase-functions');
   const adm = require('firebase-admin');

// // Create and Deploy Your First Cloud Functions
// // https://firebase.google.com/docs/functions/write-firebase-functions
//


 exports.funcs = funcs.https.onRequest((request, response) => {
   funcs.logger.info("Hello logs!", {structuredData: true});
   response.send("Hello from Firebase!");
 });
