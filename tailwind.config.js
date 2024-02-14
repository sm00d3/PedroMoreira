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
    }
  },
  daisyui: {
    darkTheme: "pmDark",
    themeRoot: ":root",
    themes: [
      {
        pmDark: {
          "primary": "#eef2ff", // Indigo-50
          "secondary": "#c7d2fe", // Indigo-200
          "accent": "#a5b4fc", // Indigo-300
          "neutral": "#e0e7ff", // Indigo-100
          "base-100": "#1e1b4b", // Indigo-950
          "info": "#fcd34d", // Indigo-950
          "success": "#84cc16", // Lime-500
          "warning": "#fb923c", // Orange-400
          "error": "#ef4444", // Red-500
        },
      },
      {
        pmlight: {
          "primary": "#3730a3", // Indigo-800
          "secondary": "#1e1b4b", // Indigo-950
          "accent": "#4338ca", // Indigo-700
          "neutral": "#6366f1", // Indigo-600
          "base-100": "#e0e7ff", // Indigo-100
          "info": "#fcd34d", // Amber-300
          "success": "#84cc16", // Lime-500
          "warning": "#fb923c", // Orange-400
          "error": "#ef4444", // Red-500
        },
      },
    ],
  },
  plugins: [
    require("daisyui")
  ],
}

