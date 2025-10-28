


using System.Linq.Expressions;

body {
    margin: 0;
    font-family: "Bookman Old Style", "Baskerville", "Times New Roman";
    display: flex;
    justify-content: flex-start;
    align-items: center;
    height: 100vh;
    background-color: white;
    }

/* Grid Container */
.container {
    display: grid;
    grid-template-columns: 1fr 1fr; /* Two columns */
    align-items: center;
    width: 80%;
    max-width: 900px;
    position: relative;
}

/* Left Side - Cherries Image */
.left {
    display: flex;
    justify-content: center;
    text-align: center;
    position: relative;
}

/* Right Side - Gray Background */
.right {
    background-color: #CACBC9;
    display: flex;
    justify-content: center;
    align-items: center;
    height: 300%;
    padding: 5px;
}

/* "Cherries" Text */
.cherries {
    color: darkred;
    font-size: 40px;
    font-weight: bold;
    letter-spacing: 0.15
}

.cherry-img {
    width: 250px;
    position: relative;
    z-index: 2; /* Ensures image is above background */
}

/* Centered "Tart & Sweet" Text Overlapping Cherries */
.title {
    position: absolute;
    font-size: 64px;
    font-weight: bold;
    top: 15%;
    left: 20%;
    z-index: 3; /* Ensures text is on top */
}

/* "Tart" & "Sweet" Styling */
.tart {
    color: black;
}

.sweet {
    color: black;
}

</style>      