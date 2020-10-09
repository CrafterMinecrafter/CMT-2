/*function ToBytesText(Text = "") {
    let Buffer = "";
    for(let i = 0;i<Text.length;i++)
        Buffer += Text.charCodeAt(i).toString(16).padStart(2,"0");
    return Buffer;
}
function FromBytesText(Text){
    let Buffer = "";
    for(let i = 0;i<Text.length;i+=2)
        Buffer += String.fromCharCode(parseInt(Text.charAt(i)+Text.charAt(i+1),16));
    return Buffer;
}
console.log(ToBytesText("testjzkaJj7@@@   "));
console.log(FromBytesText('746573746a7a6b614a6a37404040202020'));

 */
let date = new Date();
setInterval(()=>
{
    console.log(date.getSeconds() + '.' + date.getMilliseconds());
},20,null);