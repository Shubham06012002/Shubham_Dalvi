const cards = document.querySelectorAll(".cards")
const projectsR = document.querySelectorAll(".projects")

const signleObserver = new IntersectionObserver(entries => {
    console.log(entries);
    entries.forEach(entry => {
        entry.target.classList.toggle("showP", entry.isIntersecting)
        if (entry.isIntersecting) { signleObserver.unobserve(entry.target) }
    })
}, { threshold: 0.5 })


const observer = new IntersectionObserver(entries => {
    console.log(entries);
    entries.forEach(entry => {
        entry.target.classList.toggle("showC", entry.isIntersecting)
        if (entry.isIntersecting) { signleObserver.unobserve(entry.target) }
    })
}, { threshold: 0.5 })

cards.forEach(card => {
    observer.observe(card)
})
projectsR.forEach(project => {
    signleObserver.observe(project)
})


