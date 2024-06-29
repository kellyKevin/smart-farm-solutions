/* /public/styles/style.css */

body {
    font-family: Arial, sans-serif;
    margin: 0;
    padding: 0;
    background-color: #f4f4f4;
    color: #333;
}

.container {
    width: 80%;
    margin: 0 auto;
    padding: 20px;
}

header {
    background-color: #4CAF50;
    color: white;
    padding: 20px 0;
    text-align: center;
}

h1 span {
    color: #ffdd57;
}

.tagline {
    font-size: 1.2em;
    margin-top: 10px;
}

.section {
    padding: 40px 0;
    border-bottom: 1px solid #ddd;
    background-color: #fff;
}

h2 {
    color: #4CAF50;
}

p {
    font-size: 1.1em;
    line-height: 1.5;
}

.cta-button {
    background-color: #ffdd57;
    border: none;
    color: #333;
    padding: 15px 30px;
    font-size: 1.2em;
    cursor: pointer;
    margin-top: 20px;
}

.cta-button:hover {
    background-color: #ffc107;
}

form {
    display: flex;
    flex-direction: column;
    gap: 10px;
    margin-top: 20px;
}

input, button {
    padding: 10px;
    font-size: 1em;
}

footer {
    background-color: #333;
    color: white;
    padding: 20px 0;
    text-align: center;
    margin-top: 20px;
}

.popup-modal {
    display: none;
    position: fixed;
    z-index: 1;
    left: 0;
    top: 0;
    width: 100%;
    height: 100%;
    overflow: auto;
    background-color: rgba(0, 0, 0, 0.5);
}

.popup-content {
    background-color: white;
    margin: 15% auto;
    padding: 20px;
    border: 1px solid #888;
    width: 80%;
    max-width: 500px;
    text-align: center;
}

.close-btn {
    color: #aaa;
    float: right;
    font-size: 28px;
    font-weight: bold;
}

.close-btn:hover, .close-btn:focus {
    color: black;
    text-decoration: none;
    cursor: pointer;
}
