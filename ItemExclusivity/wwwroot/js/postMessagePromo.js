window.addEventListener('message', (event) => {
    if (event.origin !== 'http://192.168.100.62:97') return;

    if (event.data.session_id) {
        sessionStorage.setItem('session_id', event.data.session_id);
    }
    if (event.data.company) {
        sessionStorage.setItem('company', event.data.company);
    }
    if (event.data.userId) {
        sessionStorage.setItem('userId', event.data.userId);
    }
});
