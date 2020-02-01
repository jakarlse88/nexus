window.linkToPageSection = function(elementId) {
    let element = document.querySelector(`${elementId}`);
    console.log(elementId);
    console.log(element);
    
    element.scrollIntoView();
}

// window.onscroll = () => stickyHeader();
//
// stickyHeader = function() {
//     let navbar = document.querySelector(".navbar");
//     let content = document.querySelector(".content");
//
//     // let sticky = navbar.offsetTop;
//
//     if (window.pageYOffset >= 400)
//     {
//         navbar.classList.add('navbar-sticky');
//         content.classList.add("content-padding");
//        
//         console.log('sticky');
//     } 
//     else 
//     {
//         navbar.classList.remove('navbar-sticky');        
//         content.classList.remove("content-padding");
//
//         console.log('slippery');
//     }
// }