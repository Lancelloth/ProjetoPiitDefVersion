$(document).ready(function(){
    // Activate Carousel
    $("#carousel-img").carousel("pause");

    // Go to the previous item
    $("#myBtn").click(function(){
        $("#carousel-img").carousel("prev");
    });

    // Go to the next item
    $("#myBtn2").click(function(){
        $("#carousel-img").carousel("next");
    });
    
    // Enable Carousel Indicators
    $(".item1").click(function(){
        $("#carousel-img").carousel(0);
    });
    $(".item2").click(function(){
        $("#carousel-img").carousel(1);
    });
    $(".item3").click(function(){
        $("#carousel-img").carousel(2);
    });
    $(".item4").click(function(){
        $("#carousel-img").carousel(3);
    });
    
    // Enable Carousel Controls
    $(".left").click(function(){
        $("#carousel-img").carousel("prev");
    });
    $(".right").click(function(){
        $("#carousel-img").carousel("next");
    });
});