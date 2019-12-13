if(document.body.clientWidth > 1000)
{
window.onscroll = function () { scrollFunction() };

function scrollFunction() {
        if (document.body.scrollTop > 230 || document.documentElement.scrollTop > 230) {
            document.getElementById("teste").style.paddingBottom = "7.5em";
            document.getElementById("go").style.fontSize = "17px";
            document.getElementById("logo").style.height = "5em";
            document.getElementById("teste").style.backgroundColor = "rgb(93, 0, 109)";
            document.getElementById("teste").style.borderBottom = "1px solid black";
        } else {
            document.getElementById("teste").style.paddingBottom = "13em";
            document.getElementById("go").style.fontSize = "20.8px";
            document.getElementById("logo").style.height = "10em";
            document.getElementById("teste").style.backgroundColor = "rgba(0, 0, 0, 0.3)";
            document.getElementById("teste").style.borderBottom = "none";
        }   
    }
}else{
            document.getElementById("teste").style.paddingBottom = "7.5em";
            document.getElementById("go").style.fontSize = "17px";
            document.getElementById("logo").style.height = "5em";
            document.getElementById("teste").style.backgroundColor = "rgb(93, 0, 109)";
            document.getElementById("teste").style.borderBottom = "2px solid #ffc600";
}
