document.addEventListener('DOMContentLoaded', function () {
  const slides = document.querySelectorAll('.slide');
  const dots = document.querySelectorAll('.dot');
  let currentSlide = 0;
  let isAnimating = false;

  function showSlide(index) {
    if (isAnimating || index === currentSlide) return;
    isAnimating = true;

    const currentActive = slides[currentSlide];
    const nextSlide = slides[index];

    // Remove active class from current slide and add appropriate classes
    currentActive.classList.remove('active');
    currentActive.classList.add(index > currentSlide ? 'slide-left' : 'slide-right');
    
    // Prepare next slide
    nextSlide.classList.add('next');
    nextSlide.classList.add(index > currentSlide ? 'slide-from-right' : 'slide-from-left');

    // Update dots
    dots.forEach((dot) => dot.classList.remove('active'));
    dots[index].classList.add('active');

    // Use setTimeout to ensure class changes take effect
    setTimeout(() => {
      nextSlide.classList.remove('next');
      nextSlide.classList.add('active');
      nextSlide.classList.remove('slide-from-right', 'slide-from-left');
    }, 50);

    // Reset slide positions after animation
    setTimeout(() => {
      currentActive.classList.remove('slide-left', 'slide-right');
      isAnimating = false;
      currentSlide = index;
    }, 800);
  }

  // Dot click event
  dots.forEach((dot) => {
    dot.addEventListener('click', function () {
      const slideIndex = parseInt(this.getAttribute('data-index'));
      showSlide(slideIndex);
    });
  });

  // Initialize first slide
  slides[0].classList.add('active');
  dots[0].classList.add('active');
});