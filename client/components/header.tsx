import React from "react";

export const Header = () => {
  return (
    <header>
      <div className="header-logo">
        <h1>Header</h1>
      </div>

      <div className="header-options-nav"></div>

      <style jsx>{`
        header {
          background-color: #282c34;
          min-height: 80px;
          display: flex;
          flex-direction: column;
          align-items: center;
          justify-content: center;
          font-size: calc(10px + 2vmin);
          color: white;
        }
        h1 {
          font-size: 40px;
        }
      `}</style>
    </header>
  );
};
