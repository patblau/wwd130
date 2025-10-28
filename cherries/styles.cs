

using System; 

body {
    margin: 0;
    font-family: "Bookman Old Style", "Baskerville", "Times New Roman", serif;
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
    letter-spacing: 0.15;
}

.cherry-img {
    width: 250px;
    position: relative;
    z-index: 2; /* Ensures image is above background */
}

/* Centered "Tart & Sweet" */
.cherries {
    font-size: 40px;
    font-weight: bold;
    color: darkred;
    letter-spacing: 0.15em;
}

/* "Tart" & "Sweet" Styling */
.title {
    color: black;
    position: absolute;
    top: 15%;
    left: 10%;
    font-size: 64px;
    font-weight: bold;
    color: black;
    z-index: 2;
}




