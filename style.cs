*{
    margin: 0;
    padding: 0;
    box-sizing: border-box;
}
nav{
    background-color: rgb(249, 209, 80);
    top:0;
    z-index: 1;
}
#Toggle{
    background-color:rgb(249, 209, 80);
   
}
#Toggle:hover{
    border: none;
}
#navbarNavDropdown{
    background-color: rgb(242, 201, 98);
    /* color: white; */

    text-align: center;
    margin: 0;
}
#drop{
    background-color: rgb(242, 201, 98);
    text-align: center;
}
#b1::before{
    content: "";
    /* height: 100px; */
}
.banner{
    width: 500px;
    padding: 10px;
    margin: 20px;
    flex-direction: column;
    position: absolute;
    top: 250px;
    left: 13%;
    
}
.banner h1{
    font-size: 40px;
    font-weight: 800px;
    margin-top: 15px;
    font-weight: bolder;
}
#bt1{
    margin-top: 20px;
    border-radius: 20px;
    /* width:200px */
}
#h2o{
    background-color: rgb(243, 180, 63);
    width: 100%;
    padding:1px;
}
#c1{
    background-color: rgb(243, 180, 63);
    border: 3px inset;
    width: 300px;
    margin-left: 100px;
    


}
#c1:hover{
    transform: scale(1.1);
}
#c1 img{
    height: 200px;
}
#p1{
    color: white;
}
.col-3 img{
    width: 100%;
    height: 220px;
    box-shadow: 2px 3px 5px;
   
}
.card-img-top1::before{
content: "";
}
#btnc{
    background-color: rgb(243, 180, 63);
    border-radius: 10px;
    padding: 5px;
    flex-direction: column;
    position: absolute;
    top: 10px;
    left: 5%;
}
#h1d{
margin-left: 200px;
margin-top: 20px;
font-size: 20px;
padding: 20px;
}

#gal{
    margin-left:80px ;
}
#c2{
    margin: 20px;
    position: relative;
}
#c2 .card-img-top{
   
        width: 100%;
        height: 220px;
        box-shadow: 2px 3px 5px;
       
    }
    #c2 .card-body{
        display: flex;
        flex-direction: column;
        justify-content: center;
        align-items: center;
        position: absolute;
        top: 0;
        left: 0;
        width: 100%;
        height: 100%;
        background-color: rgba(128, 128, 128, 0.838);
        opacity: 0;
        transition: 0.3s;
        color: aliceblue;

    }
    #c2:hover .card-body{
        opacity: 1;
    }
    /* number */
    #h3o{
        background-color: rgb(243, 180, 63);
        width: 100%;
        color:white;
        padding: 7px;
        display: flex;
        text-align: center;
        margin-top: 30px;
        
    }
    .heading{
        margin-left:100px ;
    }
    #btn2{
        width: 110px;
        height: 40px;
        display: flex;
        flex-direction: row;
        margin-left: 300px;
        border-radius: 25px;
        margin-top: 28px;
        border-radius: inset 2px white;
        text-align: center;

    }
    #c3{
       border: 2px inset;
       bottom: 2px 2px 5px;
    }
   #num{
    font-size: 60px;
    font-weight:bolder;
    color: rgba(243, 208, 37, 0.911);
    text-align: center;
   }
   #c3 p{
    text-align:justify;
   }
  #c3 #num::before{
    content: "";
    }
    #ovr{
        
        padding: 5px;
        flex-direction: column;
        position: absolute;
        top:42px;
        color: rgba(0, 0, 0, 0.748);
        
        
    }
    #ctr{
        background-color: aliceblue;
    }
    #ifr{
        width: 100%;
        margin-top: 20px;
    }
    th{
        width: 33%;
        padding: 20px;
        margin: 10px;
    }
    footer{
        background-color:  rgb(245, 242, 238);
    }
    footer a{
        text-decoration: none;
        color: #8e8989;

    }
    footer a i{
        text-decoration: none;
        color: rgb(243, 180, 63) ;
        font-size: 25px;
        margin-left:10px;
    }
    @media screen and (max-width:400px){
       
        #ctr{
            width: 400px;
           
        }
#container .row .col-3 #c1 {
padding: 0;
margin: 0;
}
#h3o{
    flex-direction: column;
    margin:0;
    padding: 0;
    width: 400px;
    padding-bottom:5px ;
}
.heading{
    font-size: 30%;
    margin-left: -30px;
}
#btn2{
    text-align: center;
    margin-left: 150px;
   
}
footer{
    display: flex;
}
th{width: 400px;
    display: flex;
    flex-direction: column;
    margin: 0;
    padding: 0;
}
footer a i{
    margin: 0;
}
footer img{
    margin: auto;
}
#h1d{
    font-size: 20px;
    padding: 0;
    text-align: left;
    width: 400px;
    text-align: center;
    margin-left:-15px;
}
   
.content{

    width: 400px;
    margin: auto;
}
.content h1{
    font-size: 30px;
}
.banner h2{
    font-size: 20px;
}
.banner h1{
    font-size: 25px;
    text-align: justify;
    margin: 0;
    padding: 0;
}
#b1::before{
    content: "";
    height: 600px;
}
.banner{
    width: 300px;
    padding: 50px;
    margin: 20px;
    flex-direction: column;
    position: absolute;
    top: 50px;
    
    
}

}