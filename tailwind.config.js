/** @type {import('tailwindcss').Config} */

module.exports = {
  darkMode: 'class',
  content: [
    "./src/**/*.{html,js}"
  ],
  theme: {
    extend: {
      fontFamily: {
        sans: ['Inter', 'sans-serif'],
      },
      colors: {
        primary: 'Zinc',
        secondary: 'Indigo',
        neutral: 'Neutral'
      }
    }
  },
  plugins: [],
}

