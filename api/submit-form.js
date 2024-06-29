// /api/submit-form.js

module.exports = (req, res) => {
    const { name, email } = req.body;
    console.log('Form submitted:', name, email);
    res.json({ success: true, message: 'Form submitted successfully!' });
};
