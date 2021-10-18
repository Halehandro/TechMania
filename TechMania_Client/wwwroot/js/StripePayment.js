redirectToCheckout = function (sessionId) {
    var stripe = Stripe('pk_test_51JaozTFd6I9HEF2Kg6DHDmFr6F2qUTGYayPJq3CSRjNRWrvmuuQ3JhTbTEBKeCHie4DDgyRQyPWxbBOz5taBqDTh00QQUc357b');
    stripe.redirectToCheckout({
        sessionId: sessionId
    });
};