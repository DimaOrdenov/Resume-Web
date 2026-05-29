window.scrollObserver = {
    init: function () {
        // Scroll-reveal observer
        const revealObserver = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    entry.target.classList.add('revealed');
                    revealObserver.unobserve(entry.target);
                }
            });
        }, { threshold: 0.12, rootMargin: '0px 0px -60px 0px' });

        document.querySelectorAll('.reveal, .reveal-stagger').forEach(el => {
            revealObserver.observe(el);
        });

        // Active nav section observer
        const sections = document.querySelectorAll('section[id]');
        if (sections.length === 0) return;

        const navObserver = new IntersectionObserver((entries) => {
            entries.forEach(entry => {
                if (entry.isIntersecting) {
                    document.body.dataset.activeSection = entry.target.id;
                    document.querySelectorAll('.nav-links a').forEach(a => {
                        a.classList.toggle('active', a.getAttribute('href') === '#' + entry.target.id);
                    });
                }
            });
        }, { threshold: 0.4 });

        sections.forEach(s => navObserver.observe(s));
    }
};

window.themeToggle = {
    getTheme: function () {
        return document.documentElement.getAttribute('data-theme') || 'dark';
    },
    toggle: function () {
        const current = document.documentElement.getAttribute('data-theme') || 'dark';
        const next = current === 'dark' ? 'light' : 'dark';
        document.documentElement.setAttribute('data-theme', next);
        localStorage.setItem('theme', next);
        return next;
    }
};
