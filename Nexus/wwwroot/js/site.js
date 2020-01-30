window.linkToPageSection = function(elementId) {
    let element = document.querySelector(`${elementId}`);
    
    element.scrollIntoView();
}

window.onscroll = () => stickyHeader();

stickyHeader = function() {
    let navbar = document.querySelector(".navbar");

    // let sticky = navbar.offsetTop;

    if (window.pageYOffset >= 400)
    {
        navbar.classList.add('navbar-sticky');
        
        console.log('sticky');
    } 
    else 
    {
        // setTimeout(() => {
            navbar.classList.remove('navbar-sticky');        
        // }, 400);

        console.log('slippery');
    }
}